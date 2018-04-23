namespace QueenAttack
{
  public class QueenAttack
  {
    public bool CanQueenAttack(int QueenX, int QueenY, int PlayerX, int PlayerY)
    {
      if (QueenY == PlayerY)
      {
        return true;
        } else if (QueenX == PlayerX)
        {
          return true;
        } else {
          for(int i=0; i<9; i++)
          {
            if ((QueenX == PlayerX + i) && (QueenY == PlayerY + i))
            {
              return true;
            } else if ((QueenX == PlayerX - i) && (QueenY == PlayerY + i))
            {
              return true;
            } else if ((QueenX == PlayerX + i) && (QueenY == PlayerY - i))
            { return true;
            }  else if ((QueenX == PlayerX - i) && (QueenY == PlayerY - i))
            { return true;
            }  else {}
          }
          return false;
        }

      }
    }
  }
