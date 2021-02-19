import React, { useMemo } from 'react'
import { useTable, useRowSelect } from 'react-table'
import db from '../api/db.json';
import { Columns } from '../api/columns'
import './style.css'
import { Checkbox } from '../Checkbox/Checkbox'
import DeleteIcon from '@material-ui/icons/Delete';
import EditIcon from '@material-ui/icons/Edit';

export const Table = () => {
    const columns = useMemo(() => Columns, [])
    const data = useMemo(() => db, [])

    const {
        getTableProps,
        getTableBodyProps,
        headerGroups,
        rows,
        prepareRow,
    } = useTable(
        {
            columns,
            data
        },
        useRowSelect,
        hooks => {
            hooks.visibleColumns.push(columns => [
                {
                    id: 'selection',
                    Header: ({ getToggleAllRowsSelectedProps }) => (
                        <Checkbox {...getToggleAllRowsSelectedProps()} />
                    ),
                    Cell: ({ row }) => <Checkbox {...row.getToggleRowSelectedProps()} />
                },
                ...columns,
                {
                    id: 'actions',
                    Header: 'Ações',
                    Cell: ({ row }) => [<EditIcon color="disabled" />, <DeleteIcon color="disabled"/>]
                },
            ])
        }
    )

    const firstPageRows = rows.slice(0, 10)

    return (
        <>
            <table {...getTableProps()}>
                <thead>
                    {headerGroups.map(headerGroup => (
                        <tr {...headerGroup.getHeaderGroupProps()}>
                            {headerGroup.headers.map(column => (
                                <th {...column.getHeaderProps()}>{column.render('Header')}</th>
                            ))}
                        </tr>
                    ))}
                </thead>
                <tbody {...getTableBodyProps()}>
                    {firstPageRows.map(row => {
                        prepareRow(row)
                        return (
                            <tr onClick={()=>alert('Olá')} className="rowUser" {...row.getRowProps()}>
                                {row.cells.map(cell => {
                                    if(cell.value === true){
                                        return <td><h3 style={{color:"#31BA1F"}}>ATIVO</h3></td>
                                    }
                                    else if(cell.value === false){
                                        return <td><h3 style={{color:"#e74c3c"}}>INATIVO</h3></td>
                                    }
                                    return <td {...cell.getCellProps()}>{cell.render('Cell')}</td>
                                })}
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </>
    )
}