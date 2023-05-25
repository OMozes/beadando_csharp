using System;
using System.Collections.Generic;


class DataCollection
{
	private List<Tuple<string, int>> data = new List<Tuple<string, int>>();

	public int Count
	{
		get { return data.Count; }
	}

	public void AddData(string name, int age)
	{
		data.Add(Tuple.Create(name, age));
	}

	public string GetFirstItem()
	{
		if (data.Count > 0)
		{
			return data[0].Item1;
		}
		return null;
	}

	public bool Contains(string name)
	{
		foreach (var item in data)
		{
			if (item.Item1 == name)
			{
				return true;
			}
		}
		return false;
	}

	public int IndexOf(string name)
	{
		for (int i = 0; i < data.Count; i++)
		{
			if (data[i].Item1 == name)
			{
				return i;
			}
		}
		return -1;
	}

	public Tuple<string, int> GetLastData()
	{
		if (data.Count > 0)
		{
			return data[data.Count - 1];
		}
		return null;
	}

	public DataCollection MemberwiseClone()
	{
		DataCollection clone = new DataCollection();
		foreach (var item in data)
		{
			clone.AddData(item.Item1, item.Item2);
		}
		return clone;
	}

    public DataCollection SelectData(Func<int, bool> condition)
    {
        DataCollection selectedDataCollection = new DataCollection();
        foreach (var item in data)
        {
            if (condition(item.Item2))
            {
                selectedDataCollection.AddData(item.Item1, item.Item2);
            }
        }
        return selectedDataCollection;
    }

    public void PrintData()
	{
		foreach (var item in data)
		{
			Console.WriteLine(item.Item1 + ", " + item.Item2);
		}
	}
}