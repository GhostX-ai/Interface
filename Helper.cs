using System;
class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is opened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("You can edit document in pro version");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("You can save document in pro version");
    }
}
class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Document has been changed");
        base.EditDocument();
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Document has been saved in last format, you can save others in expert version");
        base.SaveDocument();
    }
}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Document has been saved in new format");
        base.SaveDocument();
    }
}
class PlayMusic : IPlayable
{
    public void Pause()
    {
        Console.WriteLine("I've paused music");
    }

    public void Stop()
    {
        Console.WriteLine("I've stopped music");
    }
    public void Play()
    {
        Console.WriteLine("I'm playing music");
    }
}
class RecordMusic : IRecordable
{
    public void Pause()
    {
        Console.WriteLine("I've paused music");
    }

    public void Stop()
    {
        Console.WriteLine("I've stopped music");
    }
    public void Record()
    {
        Console.WriteLine("I'm recording");
    }
}
interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}
interface IRecordable
{
    void Record();
    void Pause();
    void Stop();
}