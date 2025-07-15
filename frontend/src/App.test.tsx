import React from 'react';
import { render, screen } from '@testing-library/react';
import QLNV from './HomeQLRap';

test('renders learn react link', () => {
  render(<QLNV />);
  const linkElement = screen.getByText(/learn react/i);
  expect(linkElement).toBeInTheDocument();
});
