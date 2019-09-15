import React, { useContext } from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import Drawer from '../drawer/Drawer';
import SideBarContext from '../../../context/SideBarContext';
import { SideBarButton } from '../button';

const drawerWidth = 476;

const useStyles = makeStyles((theme) => ({
  paper: {
    left: 60,
    top: 80,
    bottom: 0,
    visibility: 'visible',
  },
  openBtn: {
    alignSelf: 'flex-start',
    marginRight: '6px',
    '&:hover': {
      background: 'rgba(142, 185, 191, 0.4)',
    },
  },
  hideDrawer: {
    marginLeft: -drawerWidth,
  },
  showDrawer: {
    marginLeft: 0,
  },
}));

const SideBar = ({ children, ...rest }) => {
  const classes = useStyles();
  const { open, toggle } = useContext(SideBarContext);

  return (
    <Drawer
      open={open}
      className={open ? classes.showDrawer : classes.hideDrawer}
      {...rest}
    >
      {children}
      {/* <Divider width='2px' height='100%' position='absolute' /> */}
      <SideBarButton
        open={open}
        onClick={toggle}
        extraClasses={{ root: classes.openBtn }}
      />
    </Drawer>
  );
};

SideBar.propTypes = {
  // isOpen: PropTypes.bool.isRequired,
  // toggle: PropTypes.func.isRequired,
  children: PropTypes.node.isRequired,
};

export default SideBar;
