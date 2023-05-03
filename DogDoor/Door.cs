﻿using System.Timers;

namespace DogDoor;

internal class Door
{
    private List<Bark> _allowedBarks;
    private static System.Timers.Timer timer;
    private bool _open;
    public Door()
    {
        _open = false;
        timer = new System.Timers.Timer(3000);
        _allowedBarks= new List<Bark>();
    }
    public void Open()
    {
        Console.WriteLine("The dog door opens");
        this._open = true;
        timer.Elapsed += Autoclose; timer.Enabled = true;
    }
    public void Close()
    {
        Console.WriteLine("The dog door closes");
        this._open = false;
        timer.Stop();
    }
    public bool isOpen()
    {
        return this._open;
    }
    private void Autoclose(object? sender, ElapsedEventArgs e)
    {
        if (isOpen()) Close(); 
    }
    public void SetTimer(int seconds)
    {
        timer.Interval = seconds * 1000;
    }

    public List<Bark> GetAllowedBarks()
    {
        return _allowedBarks;
    }
    public void AddAllowedBarks(Bark bark)
    {
        _allowedBarks.Add(bark);
    }
}
