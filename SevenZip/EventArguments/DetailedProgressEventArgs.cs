using System;

namespace SevenZip
{
  /// <summary>
  /// Event args that pass a ulong total and a ulong completed value, that can be interpreted by the receiver.
  /// </summary>
  public sealed class DetailedProgressEventArgs : EventArgs
  {
    private readonly ulong _amountedCompleted;
    private readonly ulong _total;

    /// <summary>
    /// Initializes a new instance of the DetailedProgressEventArgs class.
    /// </summary>
    /// <param name="amountCompleted">Amount of work that has been cumulatively completed.</param>
    /// <param name="total">The total amount of work to complete.</param>
    [CLSCompliant(false)]
    public DetailedProgressEventArgs(ulong amountCompleted, ulong total)
    {
      _amountedCompleted = Math.Min(total, amountCompleted);
      _total = total;
    }

    /// <summary>
    /// Gets the amount of work that has been completed.
    /// </summary>
    [CLSCompliant(false)]
    public ulong AmountCompleted => _amountedCompleted;
    /// <summary>
    /// Gets the total amount of work to do.
    /// </summary>
    [CLSCompliant(false)]
    public ulong TotalAmount => _total;
  }
}