using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///Remove(System.Object)
/// </summary>
public class ListIListRemove
{
    public static int Main()
    {
        ListIListRemove ListIListRemove = new ListIListRemove();
        TestLibrary.TestFramework.BeginTestCase("ListIListRemove");
        if (ListIListRemove.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling Remove method of IList,T is Value type.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            IList myIList = ((IList)myList);
            object element = null;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myIList.Add(element);
            }
            for (int j=0;j<count;j++ )
            {
                myIList.Remove(myIList[0]);
            }
            if (myIList.Count != 0)
            {
                TestLibrary.TestFramework.LogError("001.1", "calling Remove method can not remove the specified item." );
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling Remove method of IList,T is reference type.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            object element = null;
            IList myIList = ((IList)myList);
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myIList.Add(element);
            }
            for (int j = 0; j < count; j++)
            {
                myIList.Remove(myIList[0]);
            }
            if (myIList.Count != 0)
            {
                TestLibrary.TestFramework.LogError("002.1", "calling Remove method can not remove the specified item.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

  

}

