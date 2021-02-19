import React from 'react';
import { render, screen } from '@testing-library/react';
import Header from './header'

describe('Componente Header', () => {
    describe('Quando o Header abrir', () => {

        it('O snapshot do componente deve sempre renderizar da mesma forma', () => {
            const {container} = render(<Header/>) 

            expect(container.firstChild).toMatchSnapshot;
        })
    })
})