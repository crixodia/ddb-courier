import { Router } from "express";
import { getSucursal, createSucursal, getSucursalById, deleteSucursalById, updateSucursalById } from "../controllers/sucursal.controller";

const router = Router();

router.get('/sucursal', getSucursal);
router.get('/sucursal/:id', getSucursalById);

router.post('/sucursal', createSucursal);

router.delete('/sucursal/:id', deleteSucursalById);

router.put('/sucursal/:id', updateSucursalById);

export default router;