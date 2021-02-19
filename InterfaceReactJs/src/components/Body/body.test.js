import React from 'react';
import { render, screen } from '@testing-library/react';
import Body from './index'

it('O snapshot do componente deve sempre renderizar da mesma forma', () => {
    const {container} = render(<Body/>) 

    expect(container.firstChild).toMatchSnapshot;
})