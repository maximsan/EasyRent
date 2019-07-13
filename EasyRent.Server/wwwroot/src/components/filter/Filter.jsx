import React from 'react';
import PropTypes from 'prop-types';
import Button from '../button/Button';
import Select from '../select/Select';

const Filter = ({}) => {
  return (
    <div>
      <div>
        <Select>Select a category</Select>
      </div>
      <div>
        <Select>Select sub category</Select>
      </div>
      <div>
        <Select>Select district</Select>
      </div>
      <hr />
      free paid price from to days form to with photos last 5 days all ads last
      month
      <Button>Show</Button>
      <Button>Clear</Button>
    </div>
  );
};

export default Filter;
