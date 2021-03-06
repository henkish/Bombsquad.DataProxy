namespace Bombsquad.DataProxy.DataReaderAdaptors
{
	public interface IDataReaderAdaptorFactory
	{
		bool TryCreate<T>( IDataProxyContext context, out IDataReaderAdaptor<T> dataReaderAdaptor );
	}
}