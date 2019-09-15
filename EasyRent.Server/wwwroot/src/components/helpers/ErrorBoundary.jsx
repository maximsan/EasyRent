import React, { Component } from 'react';
import PropTypes from 'prop-types';

export default class ErrorBoundary extends Component {
  state = {
    error: null,
  };

  componentDidCatch(error, info) {
    this.setState({ error });
  }

  render() {
    const { error } = this.state;
    const { children } = this.props;

    return (
      <>
        {!error ? (
          children
        ) : (
          <p>Error happens here. Please look into it: {error}</p>
        )}
      </>
    );
  }
}

ErrorBoundary.propTypes = {
  children: PropTypes.element.isRequired,
};

ErrorBoundary.defaultProps = {};
