import React from 'react';
import TuneIcon from '@material-ui/icons/Tune';
import CloseIcon from '@material-ui/icons/Close';
import HdrStrongIcon from '@material-ui/icons/HdrStrong';
import DateRangeIcon from '@material-ui/icons/DateRange';
import ArrowDropDownIcon from '@material-ui/icons/ArrowDropDown';
import './style.css';

const Modal = ({onClose = () => { }, children}) => {
    return (
        <div className="modal">
            <div className="container">
                <div className="headerModal">
                    <div className="leftSideHeaderModal">
                        <TuneIcon color="disabled"></TuneIcon>
                        <h3>FILTROS</h3>
                    </div>

                    <div className="rightSideHeaderModal">
                        <span className="closeButton">
                            <CloseIcon onClick={onClose} cli></CloseIcon>
                        </span>
                    </div>
                </div>

                <div className="bodyModal">
                    <div>
                        <p>Utilize os filtros abaixo para refinar os resultdos da table, clique no botão APLICAR para salvar as alterações</p>
                    </div>

                    <div className="filters">
                        <span>
                            <div className="dateInclusion">
                                <DateRangeIcon color="disabled"></DateRangeIcon>
                                <h3>TODAS AS DATAS DE INCLUSÃO</h3>

                            </div>

                            <ArrowDropDownIcon></ArrowDropDownIcon>
                        </span>

                        <span>
                            <div className="dateAlteration">
                                <DateRangeIcon color="disabled"></DateRangeIcon>
                                <h3>TODAS AS DATAS DE ALTERAÇÃO</h3>
                            </div>

                            <ArrowDropDownIcon></ArrowDropDownIcon>
                        </span>

                        <span>
                            <div className="validActive">
                                <HdrStrongIcon color="disabled"></HdrStrongIcon>
                                <h3>ATIVOS E INATIVOS</h3>
                            </div>

                            <ArrowDropDownIcon></ArrowDropDownIcon>
                        </span>
                    </div>

                    <div className="buttonFilter">
                        <span>
                            <h3>APLICAR</h3>
                        </span>
                    </div>
                </div>

            </div>
        </div>
    )
}

export default Modal;
