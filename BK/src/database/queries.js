export const queries = {
    // Sucursal
    getSucursal: "select * from sucursal",
    getSucursalById: "select * from sucursal where CODIGO_SUCURSAL = @id",
    createSucursal: "insert into sucursal (PROVINCIA_SUCURSAL, CIUDAD_SUCURSAL, DIRECCION_SUCURSAL) values (@provincia, @ciudad, @direccion)",
    deleteSucursalById: "delete from sucursal where CODIGO_SUCURSAL = @id",
    updateSucursalById: "update sucursal set PROVINCIA_SUCURSAL = @provincia, CIUDAD_SUCURSAL = @ciudad, DIRECCION_SUCURSAL = @direccion where CODIGO_SUCURSAL = @id",

    // Vehiculo
    getVehiculo: "select * from vehiculo",

    // Cliente
    getCliente: "select * from cliente",

    // Empleado
    getEmpleado: "select * from empleado",

    // Guia
    getGuia: "select * from guia",

    // Estado paquete
    getEstadoPaquete: "select * from estado_paquete",
};