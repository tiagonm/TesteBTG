select v.placa,c.nome from Veiculo v
inner join Cliente c
	on v.Cliente_cpf = c.cpf


select e.dtEntrada,e.dtSaida from Estaciona e
	inner join Patio p 
		on e.patio_num = p.num
where e.num_placa='BTG-2022'