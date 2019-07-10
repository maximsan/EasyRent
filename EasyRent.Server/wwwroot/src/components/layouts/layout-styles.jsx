import { makeStyles } from '@material-ui/core/styles';

const LayoutStyles = makeStyles({
  main: {
    height: '100%',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    flex: '1',
    background: '#E8F6F8',
    position: 'relative',
  },
  page: {
    position: 'absolute',
  },
  'fade-enter': {
    opacity: 0,
  },
  'fade-enter-active': {
    opacity: 1,
    transition: 'opacity 200ms',
  },
  'fade-exit': {
    opacity: 1,
  },
  'fade-exit-active': {
    opacity: 0,
    transition: 'opacity 200ms',
  },
});

export default LayoutStyles;
