import { createMuiTheme } from '@material-ui/core/styles';

const theme = createMuiTheme({
  overrides: {
    MuiButton: {
      root: {
        backgroundColor: '#086574',
      },
      contained: {
        backgroundColor: '#086574',
      },
    },
    MuiIconButton: {
      colorPrimary: {
        color: '#086574',
      },
    },
    MuiCheckbox: {
      colorPrimary: {
        '&$checked': {
          color: '#086574',
        },
      },
    },
  },
});

export default theme;
