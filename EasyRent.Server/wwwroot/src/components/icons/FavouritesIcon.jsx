import React from 'react';
import PropTypes from 'prop-types';
import FavouritesIcon from '@material-ui/icons/FavoriteBorderOutlined';
import { makeStyles } from '@material-ui/core';
import FabIcon from './common/FabIcon';

const useClasses = makeStyles((theme) => ({
  fabIconRoot: {
    background: '#c2e4e8',
    border: '1.5px solid #118fa3',
    boxShadow:
      '0px 3px 5px -1px rgba(17,143,163,0.2), 0px 6px 10px 0px rgba(17,143,163,0.14), 0px 1px 18px 0px rgba(17,143,163,0.12)',
    margin: theme.spacing(1),
    '&:hover': {
      background: '#fff',
      border: '1.5px #118fa3 solid',
    },
  },
}));

const CustomFavouritesIcon = ({ size, fontSize, title, variant, ...rest }) => {
  const { fabIconRoot } = useClasses();

  return (
    <FabIcon
      fabClasses={{ root: fabIconRoot }}
      size={size}
      fontSize={fontSize}
      titleAccess={title}
      variant={variant}
      viewBox='0 0 24 24'
      {...rest}
    >
      <FavouritesIcon />
    </FabIcon>
  );
};

CustomFavouritesIcon.defaultProps = {
  size: 'medium',
  fontSize: 'medium',
  title: '',
  variant: 'round',
};

CustomFavouritesIcon.propTypes = {
  size: PropTypes.string,
  fontSize: PropTypes.string,
  title: PropTypes.string,
  variant: PropTypes.string,
};

export default CustomFavouritesIcon;
