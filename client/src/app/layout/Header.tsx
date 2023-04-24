import { AppBar, Card, Toolbar, Typography } from "@mui/material";
import CustomSwitch from "./Switch";




export default function Header() {
    return (
     
     
            <AppBar position='static' sx={{ mb: 4 }}>
                <Toolbar>
                    <Typography variant='h6'>
                        <img style={{ maxWidth: "3%" }}
                            src={require('./logo.png')}
                            alt="Logo" />
                    </Typography>

                </Toolbar>
            </AppBar>
          
       
       
    )
}