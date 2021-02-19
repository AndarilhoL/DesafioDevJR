import React from 'react';
import { render, screen } from '@testing-library/react';
import Date from '../Date/index'
import Footer from './index'

describe('Componente Footer', () => {
    describe('Quando o footer abrir', () => {
        it('NO AR está sendo exibido', () => {
            render(<Footer></Footer>);

            expect(screen.getByText('NO AR')).toBeInTheDocument;
        }),

            it('O snapshot do componente deve sempre renderizar o Date', () => {
                const {container} = render(<Date/>) 

                expect(container.firstChild).toMatchSnapshot;
            })
    })
})