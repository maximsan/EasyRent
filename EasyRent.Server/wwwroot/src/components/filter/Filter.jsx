import React, { useState } from 'react';
import { makeStyles } from '@material-ui/core';
import PropTypes from 'prop-types';
import { ContainedButton } from '../common/button';
import Select from '../common/select/Select';
import CheckBoxGroup from '../common/checkbox/CheckBoxGroup';
import CheckBox from '../common/checkbox/Checkbox';
import InputGroup from '../common/inputGroup/InputGroup';
import customClasses from './Filter.module.css';

const useClasses = makeStyles({
  withPhotosRoot: {
    alignSelf: 'flex-start',
    marginLeft: '18px',
  },
  showBtn: {
    boxSizing: 'border-box',
    // background: '#086574',
    color: '#fff',
    border: '2px solid #8EB9BF',
    marginRight: '140px',
    transition: '0.4s all ease-in-out',
    '&:hover': {
      boxSizing: 'border-box',
      color: '#020f11',
      background: '#8EB9BF',
      border: '2px solid #086574',
    },
  },
});

const Filter = ({}) => {
  const classes = useClasses();
  const [price, setPrice] = useState({ from: 0, to: 0 });
  const [days, setDays] = useState({ from: 0, to: 0 });
  const [values, setValues] = useState({
    category: [],
    subCategory: [],
    district: [],
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
      <Select name='district' value={values.district} onChange={onSelectChange}>
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
        <ContainedButton extraClasses={{ contained: classes.showBtn }}>
          Show
        </ContainedButton>
        <ContainedButton>Clear</ContainedButton>
      </div>
    </div>
  );
};

Filter.defaultProps = {};

Filter.propTypes = {};

export default Filter;
