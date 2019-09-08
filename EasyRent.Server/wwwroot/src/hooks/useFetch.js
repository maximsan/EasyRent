import { useEffect, useState } from 'react';
import axios from 'axios';

const baseUrl = process.env.REACT_APP_BASE_URL;

// Set config defaults when creating the instance
const instance = axios.create({
  baseURL: 'https://api.unsplash.com/',
});

const useFetch = (method, url) => {
  const [fetchedData, setFetchedData] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      const { data } = await instance({
        method,
        url,
      });
      setFetchedData(data);
    };

    fetchData();
  }, [method, url]);

  return [fetchedData];
};

export default useFetch;
