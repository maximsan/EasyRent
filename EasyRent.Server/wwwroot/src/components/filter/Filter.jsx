import React, { useState } from 'react';
import PropTypes from 'prop-types';
import Button from '../button/Button';
import Select from '../select/Select';
import CheckBoxGroup from '../checkbox/CheckBoxGroup';
import InputGroup from '../inputGroup/InputGroup';
import customClasses from './Filter.module.css';

const Filter = ({}) => {
  const [price, setPrice] = useState({ priceFrom: 0, priceTo: 0 });

  const onChange = (event) => {
    event.persist();
    setPrice((prevState) => ({
      ...prevState,
      [event.target.name]: event.target.value,
    }));
  };

  return (
    <aside className={customClasses.filter}>
      <Select>Select a category</Select>
      <Select>Select sub category</Select>
      <Select>Select district</Select>
      <hr />
      <CheckBoxGroup items={[{ label: 'free' }, { label: 'paid' }]} />
      <InputGroup
        label='Price'
        items={[
          {
            placeholder: 'from',
            name: 'priceFrom',
            value: price.priceFrom,
            onChange,
          },
          {
            placeholder: 'to',
            name: 'priceTo',
            value: price.priceTo,
            onChange,
          },
        ]}
      />
      <InputGroup
        label='Days'
        items={[{ placeholder: 'from' }, { placeholder: 'to' }]}
      />
      with photos last 5 days all ads last month
      <div>
        <Button>Show</Button>
        <Button>Clear</Button>
      </div>
    </aside>
  );
};

export default Filter;
