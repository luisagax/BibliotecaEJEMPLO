--TIPO TABLA T_RENTADETALLE
CREATE TYPE [dbo].[t_RentaDetalle] AS TABLE(
	[id] [int] NULL,
	[idRenta] [int] NULL,
	[idLibro] [int] NULL,
	[Titulo] [varchar](100) NULL
)
GO
--PROCEDIMIENTO ALMACENADO SPRENTA
create procedure [dbo].[spRenta]
@op tinyint,
@id int = null,
@FechaRenta date = null,
@FechaRegreso date = null,
@Multa decimal(18,2) = 0,
@Cantidad int = 0,
@idCliente int = 0,
@detalles dbo.t_RentaDetalle readonly
as
	if @op = 1
	begin
		select * from Renta where id = @id
	end
	if @op = 2
	begin
		if not exists(select * from Renta where id = @id)
		begin
			begin transaction
				set @id = (select isnull(MAX(id),0) + 1 from Renta)
				insert into Renta values (@id, @FechaRenta, @FechaRegreso, @Multa, @Cantidad, @idCliente)
				insert into RentaDetalle (id, idRenta, idLibro) select id, @id, idLibro from @detalles
				if @@ERROR > 0
				begin
					rollback transaction
					raiserror('Ocurrió un error al llevar a cabo la operación',16,0)
				end
				else
				begin
					commit transaction
				end
			end
			else
			begin
				update Renta set FechaRenta = @FechaRenta, FechaRegreso = @FechaRegreso, Multa = @Multa, Cantidad = @Cantidad, idCliente = @idCliente where id = @id
				delete from RentaDetalle where idRenta = @id
				insert into RentaDetalle (id, idRenta, idLibro) select id, @id,idLibro from @detalles
				if @@ERROR > 0
				begin
					rollback transaction
					raiserror('Ocurrió un error al modificar los datos',16,0)
				end
				else
				begin
					commit transaction
				end
			end
		end

GO
-- PROCEDIMIENTO ALMACENADO SPRENTADETALLE
CREATE procedure [dbo].[spRentaDet]
@id int
as
begin
	declare @detalle dbo.t_RentaDetalle
	insert into @detalle (id, idRenta, idLibro, Titulo) 
	select rd.id, rd.idLibro, rd.idRenta, l.Titulo from RentaDetalle rd
	inner join Libros l on rd.idLibro = l.id 
	where rd.idRenta = @id
	order by rd.id
	select * from @detalle
end