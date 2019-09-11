import React, { useRef, useState, useEffect, useCallback } from 'react';
import { MasonryDiv, ColumnDiv } from './styled';

const Masonry = ({
  children,
  columnsCount,
  gap,
  marginColumnY = 1,
  marginColumnX = 0.5,
  width = 300,
}) => {
  const [columns, setColumns] = useState([]);
  const [numOfColumns, setNumOfColumns] = useState(columnsCount);
  const ref = useRef();

  const calcNumOfColumns = useCallback(() => {
    setNumOfColumns(Math.floor(ref.current.offsetWidth / width));
  }, [width]);

  const createColumns = useCallback(() => {
    for (let i = 0; i < numOfColumns; i += 1) {
      columns[i] = [];
    }

    if (!children) {
      return;
    }

    children.forEach((child, i) => {
      columns.length && columns[i % numOfColumns].push(child);
    });
  }, [columns, numOfColumns, children]);

  useEffect(() => {
    calcNumOfColumns();
    window.addEventListener('resize', calcNumOfColumns);

    return () => {
      window.removeEventListener('resize', calcNumOfColumns);
    };
  }, [calcNumOfColumns]);

  createColumns();

  const columnDivWidth = width + 2 * marginColumnX * 16;
  const masonryDivWidth = numOfColumns * columnDivWidth;

  return (
    // TODO: Need to improve: apply width to masonry accordingly to the count and size of the loading images

    <MasonryDiv ref={ref} gap={gap} width={masonryDivWidth}>
      {Array(numOfColumns)
        .fill()
        .map((el, index) => (
          <ColumnDiv width={columnDivWidth} key={`${index} ${gap}`} gap={gap}>
            {columns[index]}
          </ColumnDiv>
        ))}
    </MasonryDiv>
  );
};

export default Masonry;
