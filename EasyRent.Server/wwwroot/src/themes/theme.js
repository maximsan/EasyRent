import { createMuiTheme } from '@material-ui/styles';

const theme = createMuiTheme({
  overrides: {
    MuiButton: {
      root: {
        backgroundColor: '#086574',
      },
    },
  },
});

export default theme;
