import React from 'react';
import clsx from 'clsx';
import { makeStyles } from '@material-ui/core/styles';
import { CssBaseline, IconButton } from '@material-ui/core';
import InboxIcon from '@material-ui/icons/MoveToInbox';
import MailIcon from '@material-ui/icons/Mail';
import MenuIcon from '@material-ui/icons/Menu';
import ChevronLeftIcon from '@material-ui/icons/ChevronLeft';
import ChevronRightIcon from '@material-ui/icons/ChevronRight';
import Filter from '../filter/Filter';
import Divider from '../divider/Divider';
import Drawer from '../drawer/Drawer';
import Button from '../button/ContainedButton';

const useStyles = makeStyles((theme) => ({
  paper: {
    left: 60,
    top: 80,
    visibility: 'visible',
  },
  chevronBtn: {
    alignSelf: 'flex-start',
  },
}));

const SideBar = ({ children }) => {
  const classes = useStyles();
  const [open, setOpen] = React.useState(false);

  function handleSideBarOpen() {
    setOpen(true);
  }

  function handleSideBarClose() {
    setOpen(false);
  }

  return (
    <Drawer open={open}>
      <Filter />
      {/* <Divider width='2px' height='100%' position='absolute' /> */}
      <Button addClasses={{ root: classes.chevronBtn }}>
        <ChevronRightIcon />
      </Button>
    </Drawer>
  );
};

export default SideBar;
