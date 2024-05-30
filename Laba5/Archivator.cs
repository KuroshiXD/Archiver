public delegate void ProgressBarUpdateHandler(int value);

public class Archivator
{
    public event ProgressBarUpdateHandler ProgressBarUpdated;

    public void Pack(string inputFile, string outputFile, CancellationToken cancellationToken)
    {
        using (var input = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
        using (var output = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
        {
            int count;
            long totalBytes = input.Length;
            long processedBytes = 0;

            while ((count = input.ReadByte()) != -1)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }

                int runLength = 1;
                byte currentByte = (byte)count;
                while (runLength < 255 && (count = input.ReadByte()) == currentByte)
                {
                    runLength++;
                }
                if (count != currentByte && count != -1)
                {
                    input.Position -= 1;
                }
                output.WriteByte(currentByte);
                output.WriteByte((byte)runLength);

                processedBytes += runLength;
                int progress = (int)((double)processedBytes / totalBytes * 100);
                OnProgressBarUpdated(progress);
            }
            OnProgressBarUpdated(100);
        }
    }

    public void UnPack(string inputFile, string outputFile, CancellationToken cancellationToken)
    {
        using (var input = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
        using (var output = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
        {
            int count;
            long totalBytes = input.Length;
            long processedBytes = 0;

            while ((count = input.ReadByte()) != -1)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }

                byte value = (byte)count;
                int runLength = input.ReadByte();
                for (int i = 0; i < runLength; i++)
                {
                    output.WriteByte(value);
                }

                processedBytes += runLength;
                int progress = (int)((double)processedBytes / totalBytes * 100);
                OnProgressBarUpdated(progress);
            }
            OnProgressBarUpdated(100);
        }
    }

    protected virtual void OnProgressBarUpdated(int value)
    {
        ProgressBarUpdated?.Invoke(value);
    }
}
