import React from 'react';
import clsx from 'clsx';
import { makeStyles } from '@material-ui/core/styles';
import { CssBaseline, IconButton } from '@material-ui/core';
import InboxIcon from '@material-ui/icons/MoveToInbox';
import MailIcon from '@material-ui/icons/Mail';
import MenuIcon from '@material-ui/icons/Menu';
import Filter from '../filter/Filter';
import Divider from '../divider/Divider';
import Drawer from '../drawer/Drawer';
import Button from '../button/ContainedButton';
import SideBarButton from '../button/SideBarButton';

const drawerWidth = 480;

const useStyles = makeStyles((theme) => ({
  paper: {
    left: 60,
    top: 80,
    visibility: 'visible',
  },
  openBtn: {
    alignSelf: 'flex-start',
  },
  hideDrawer: {
    marginLeft: -drawerWidth,
  },
  showDrawer: {
    marginLeft: 0,
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

  function toggleSideBar() {
    setOpen(!open);
  }

  return (
    <Drawer
      open={open}
      className={open ? classes.showDrawer : classes.hideDrawer}
    >
      {children}
      {/* <Divider width='2px' height='100%' position='absolute' /> */}
      <SideBarButton
        open={open}
        onClick={toggleSideBar}
        extraClasses={{ root: classes.openBtn }}
      />
    </Drawer>
  );
};

export default SideBar;
