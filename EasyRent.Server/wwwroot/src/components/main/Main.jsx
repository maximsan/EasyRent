import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, Item, ImagesDiv } from './styled';
import Header from '../header/Header';
import Filter from '../filter/Filter';
import Images from '../masonry/Images';

// const useClasses = makeStyles({
//   root: {
//     minHeight: '100%',
//   },
// });

// Set config defaults when creating the instance
const instance = axios.create({
  baseURL: 'https://api.unsplash.com/',
});

const Main = () => {
  // const classes = useClasses();
  const [images, setImages] = useState(null);

  useEffect(() => {
    const fetchImages = async () => {
      const { data } = await instance({
        method: 'get',
        url: `photos/?per_page=10&client_id=${process.env.REACT_APP_PHOTO_ACCESS_KEY}`,
      });
      setImages(data);
    };
    fetchImages();
  }, []);

  return (
    <Container>
      <Header />
      <Filter />
      <ImagesDiv>
        <Images images={images} />
      </ImagesDiv>
    </Container>
  );
};

export default Main;
