using System;

namespace BLESerial
{
    public struct Skill_ID
    {
        long value;

        public static implicit operator Skill_ID(int v)
        {
            return new Skill_ID() { value = v };
        }

        public static implicit operator long(Skill_ID v)
        {
            return v.value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}