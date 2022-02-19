import { getConnection, sql, queries } from '../database';

export const getSucursal = async (req, res) => {
    try {
        const pool = await getConnection();
        const result = await pool.request().query(queries.getSucursal);
        res.json(result.recordset);
    } catch (error) {
        res.status(500);
        res.send(error.message);
    }
};

export const getSucursalById = async (req, res) => {
    const { id } = req.params;
    try {
        const pool = await getConnection();
        const result = await pool.request()
            .input('id', id)
            .query(queries.getSucursalById);

        res.json(result.recordset[0]);
    } catch (error) {
        res.status(500);
        res.send(error.message);
    }
};


export const deleteSucursalById = async (req, res) => {
    const { id } = req.params;
    try {
        const pool = await getConnection();
        const result = await pool.request()
            .input('id', id)
            .query(queries.deleteSucursalById);

        return res.status(200).json({
            ok: true,
            message: "Sucursal eliminada correctamente"
        });
    } catch (error) {
        res.status(500);
        res.send(error.message);
    }
};


export const createSucursal = async (req, res) => {
    const { provincia, ciudad, direccion } = req.body;

    if (provincia == null || ciudad == null || direccion == null) {
        return res.status(400).json({
            ok: false,
            message: "Falta algun dato"
        });
    }

    try {
        const pool = await getConnection();
        await pool.request()
            .input('provincia', sql.Text, provincia)
            .input('ciudad', sql.Text, ciudad)
            .input('direccion', sql.Text, direccion)
            .query(queries.createSucursal);

        return res.status(200).json({
            ok: true,
            message: "Sucursal creada correctamente"
        });
    } catch (error) {
        res.status(500);
        res.send(error.message);
    }
};


export const updateSucursalById = async (req, res) => {
    const { provincia, ciudad, direccion } = req.body;
    const { id } = req.params;
    if (provincia == null || ciudad == null || direccion == null) {
        return res.status(400).json({
            ok: false,
            message: "Falta algun dato"
        });
    }

    try {
        const pool = await getConnection();
        await pool.request()
            .input('provincia', sql.Text, provincia)
            .input('ciudad', sql.Text, ciudad)
            .input('direccion', sql.Text, direccion)
            .input('id', id)
            .query(queries.updateSucursalById);

        return res.status(200).json({
            ok: true,
            message: "Sucursal actualizada correctamente"
        });
    } catch (error) {
        res.status(500);
        res.send(error.message);
    }
}