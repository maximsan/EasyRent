import React, { useState } from 'react';
import { makeStyles } from '@material-ui/core';
import PropTypes from 'prop-types';
import Button from '../button/ContainedButton';
import Select from '../select/Select';
import CheckBoxGroup from '../checkbox/CheckBoxGroup';
import CheckBox from '../checkbox/Checkbox';
import InputGroup from '../inputGroup/InputGroup';
import customClasses from './Filter.module.css';

const useClasses = makeStyles({
  withPhotosRoot: {
    alignSelf: 'flex-start',
    marginLeft: '29px',
  },
  showBtn: {
    background: '#086574',
    color: '#fff',
    marginRight: '140px',
  },
});

const Filter = ({}) => {
  const classes = useClasses();
  const [price, setPrice] = useState({ from: 0, to: 0 });
  const [days, setDays] = useState({ from: 0, to: 0 });
  const [values, setValues] = useState({
    category: null,
    subCategory: null,
    selectDistrict: null,
  });

  const onChange = (event) => {
    event.persist();
    setPrice((prevState) => ({
      ...prevState,
      [event.target.name]: event.target.value,
    }));
  };

  const onPriceChange = (event) => {
    onChange(event);
  };

  const onDaysChange = (event) => {
    onChange(event);
  };

  const onSelectChange = (event) => {
    event.persist();
    setValues((prevState) => ({
      ...prevState,
      [event.target.name]: [
        ...prevState[event.target.name],
        event.target.value,
      ],
    }));
  };

  return (
    <div className={customClasses.filter}>
      <Select name='category' value={values.category} onChange={onSelectChange}>
        Select a category
      </Select>
      <Select
        name='subCategory'
        value={values.subCategory}
        onChange={onSelectChange}
      >
        Select sub category
      </Select>
      <Select
        name='district'
        value={values.selectDistrict}
        onChange={onSelectChange}
      >
        Select district
      </Select>
      <hr />
      <CheckBoxGroup items={[{ label: 'free' }, { label: 'paid' }]} />
      <InputGroup
        label='Price'
        items={[
          {
            placeholder: 'from',
            name: 'priceFrom',
            value: price.from,
            onPriceChange,
          },
          {
            placeholder: 'to',
            name: 'priceTo',
            value: price.to,
            onPriceChange,
          },
        ]}
      />
      <InputGroup
        label='Days'
        items={[
          {
            placeholder: 'from',
            name: 'daysFrom',
            value: days.from,
            onDaysChange,
          },
          { placeholder: 'to', name: 'daysTo', value: days.to, onDaysChange },
        ]}
      />
      <CheckBox
        classes={{ root: classes.withPhotosRoot }}
        label='with photos'
      />
      <CheckBoxGroup
        items={[
          { label: 'last 5 days', name: 'last_5_Days' },
          { label: 'last 10 days', name: 'last_10_Days' },
          { label: 'last month', name: 'lastMonth' },
          { label: 'all ads', name: 'allAds' },
        ]}
      />
      <div className={customClasses.btnGroup}>
        <Button addClasses={{ contained: classes.showBtn }}>Show</Button>
        <Button>Clear</Button>
      </div>
    </div>
  );
};

export default Filter;
