import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, ContentSection, MainSection } from './styled';
import Header from '../../components/header/Header';
import Filter from '../../components/filter/Filter';
import Images from '../../components/masonry/Images';
import Footer from '../../components/footer/Footer';

// Set config defaults when creating the instance
const instance = axios.create({
  baseURL: 'https://api.unsplash.com/',
});

const Main = () => {
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
    <>
      <Header />
      <MainSection>
        <Filter />
        <ContentSection>
          <Images images={images} />
        </ContentSection>
      </MainSection>
      <Footer />
    </>
  );
};

export default Main;
