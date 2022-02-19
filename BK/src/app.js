import express from 'express';
import config from './config';
import sucursalRoutes from './routes/sucursal.routes';
import bodyParser from 'body-parser';

// settings
const app = express();
app.set('port', config.port);

// middlewares
app.use(bodyParser.json());
app.use(sucursalRoutes);
app.use(express.urlencoded({ extended: true }));
app.use(express.json());

export default app;