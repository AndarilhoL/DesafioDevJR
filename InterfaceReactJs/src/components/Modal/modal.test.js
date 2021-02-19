import React from 'react';
import { render, screen } from '@testing-library/react';
import Modal from './index'

it('O snapshot do componente deve sempre renderizar da mesma forma', () => {
    const {container} = render(<Modal/>) 

    expect(container.firstChild).toMatchSnapshot;
})