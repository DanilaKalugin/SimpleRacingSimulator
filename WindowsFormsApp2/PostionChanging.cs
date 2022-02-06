using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class PositionChanging
    {
        public enum Direction { Up, Down };

        public static void groupNumberChanging(int step, Direction direction, List<string> groups, ref int groupNumber)
        {
            switch (direction)
            {
                case Direction.Up:
                    {
                        if (groupNumber < groups.Count - step)
                        {
                            groupNumber += step;
                        }
                        else if (groupNumber < groups.Count - 1)
                        {
                            groupNumber = groups.Count - 1;
                        }
                        else
                        {
                            groupNumber = 0;
                        }
                        break;
                    }
                case Direction.Down:
                    {
                        if (groupNumber > step - 1)
                        {
                            groupNumber -= step;
                        }
                        else if (groupNumber > 0)
                        {
                            groupNumber = 0;
                        }
                        else
                        {
                            groupNumber = groups.Count - 1;
                        }
                        break;
                    }
            }
        }

        public static void elementNumberChanging<T>(int step, Direction direction, List<T> group, ref int elementNumber)
        {
            switch (direction)
                {
                    case Direction.Up:
                        {
                            if (elementNumber < group.Count - step)
                            {
                                elementNumber += step;
                            }
                            else
                            {
                                elementNumber = group.Count - 1;
                            }
                            break;
                        }
                    case Direction.Down:
                        {
                            if (elementNumber > step)
                            {
                                elementNumber -= step;
                            }
                            else
                            {
                                elementNumber = 0;
                            }
                            break;
                        }
                }
        }
    }
}