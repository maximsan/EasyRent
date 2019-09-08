import { useEffect, useState, useRef } from 'react';
import axios from 'axios';

const baseUrl = process.env.REACT_APP_BASE_URL;

// Set config defaults when creating the instance
const instance = axios.create({
  baseURL: 'https://api.unsplash.com/',
});

const useFetch = (method, url) => {
  const [fetchedData, setFetchedData] = useState(null);
  const isFetched = useRef(false);

  useEffect(() => {
    // const data = window.localStorage.getItem('images');

    // if (data) {
    //   setFetchedData(JSON.parse(data));
    //   return;
    // }
    let fetchData = null;

    if (!isFetched.current) {
      fetchData = async () => {
        const { data } = await instance({
          method,
          url,
        });
        // window.localStorage.setItem('images', JSON.stringify(data));
        isFetched.current = true;
        setFetchedData(data);
      };
    }
    fetchData();
  }, [method, url]);

  return [fetchedData];
};

export default useFetch;
