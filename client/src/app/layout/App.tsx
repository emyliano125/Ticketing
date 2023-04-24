import VizualizareTicketePrimite from "../../features/vizualizareTicketePrimite/VizualizareTicketePrimite";
import { Container, CssBaseline, ThemeProvider, Typography, createTheme } from "@mui/material";
import Header from "./Header";
import { useState } from "react";
import CustomSwitch from "./Switch";


function App() {
  const [darkMode, setDarkmode] = useState(false);
  const paletteType = darkMode ? 'dark' : 'light'
  const theme = createTheme({
    palette: {
      mode: paletteType,
      background:{
          default: paletteType === 'light' ? '#eaeaea' : '#121212'
      } 
    }
  })

  function handleThemeChange() {
    setDarkmode(!darkMode);
  }

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Header />
      <Container>
        <VizualizareTicketePrimite />
      </Container>
      <Typography sx={{position:"absolute", bottom:5, right:5,zIndex:30000}}>
        <CustomSwitch darkMode={darkMode} handleThemeChange={handleThemeChange} />
      </Typography>
    </ThemeProvider>
  );
}

export default App;
