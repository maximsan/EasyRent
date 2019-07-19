import { makeStyles } from '@material-ui/core/styles';

const LayoutStyles = makeStyles({
  main: {
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    flex: '1',
    // height: '100%',
    position: 'relative',
    background: '#E8F6F8',
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
