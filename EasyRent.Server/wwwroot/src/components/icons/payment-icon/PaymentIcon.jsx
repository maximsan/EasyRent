import React from 'react';
import PropTypes from 'prop-types';
import Icon from '../common/Icon';

const PaymentIcon = ({ fontSize, title, ...rest }) => {
  return (
    <Icon
      fontSize={fontSize}
      title={title}
      placement='top'
      viewBox='0 0 24 24'
      {...rest}
    >
      <path fill='none' d='M0 0h24v24H0V0z' />
      <path d='M20 4H4c-1.11 0-1.99.89-1.99 2L2 18c0 1.11.89 2 2 2h16c1.11 0 2-.89 2-2V6c0-1.11-.89-2-2-2zm0 14H4v-6h16v6zm0-10H4V6h16v2z' />
    </Icon>
  );
};

PaymentIcon.defaultProps = {
  fontSize: '',
  title: '',
};

PaymentIcon.propTypes = {
  fontSize: PropTypes.string,
  title: PropTypes.string,
};

export default PaymentIcon;
