import { makeStyles } from '@material-ui/core/styles';

const IconClasses = makeStyles((theme) => ({
  root: {
    color: '#020F11',
  },
  fabRoot: {
    border: '1.5px #E8F6F8 solid',
    background: '#fff',
    '&:hover': {
      background: '#E8F6F8',
    },
  },
  svgIconRoot: {
    opacity: '0.6',
  },
}));

export default IconClasses;
