import { useState } from 'react';

const useToggle = () => {
  const [isOpen, setOpen] = useState(false);

  const open = () => {
    setOpen(true);
  };

  const close = () => {
    setOpen(false);
  };

  const toggle = () => {
    setOpen(!isOpen);
  };

  return [isOpen, toggle, open, close];
};

export default useToggle;
