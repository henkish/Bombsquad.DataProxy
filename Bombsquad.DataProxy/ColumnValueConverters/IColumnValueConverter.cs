﻿using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Bombsquad.DataProxy.ColumnValueConverters
{
	public interface IColumnValueConverter<TValue>
	{
		TValue Read( SqlDataReader reader, int ordinal );
		Task<TValue> ReadAsync( SqlDataReader reader, int ordinal );
	}
}
