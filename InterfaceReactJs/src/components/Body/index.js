import React, { useState } from 'react';
import {Table} from '../Table/Table';
import './styles.css';

export default function () {

    return (
        <div>
            <div className="tableUser">
                <Table></Table>
            </div>

            <div className="buttonsGroup">
                <span>
                    <h3>Primeiro</h3>
                </span>

                <span>
                    <h3>Anterior</h3>
                </span>

                <span className="pageNumber">
                    <h3>1</h3>
                </span>

                <span>
                    <h3>Próximo</h3>
                </span>

                <span>
                    <h3>Último</h3>
                </span>
            </div>
        </div>
    );
}