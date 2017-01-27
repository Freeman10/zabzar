using System;

namespace Boris
{
    [Flags]
    public enum SlužbyVlaku
    {
        PřepravaSpoluzavazadel = 1,
        PovinněMístenkový = 2,
        JenLůžkoLehátko = 4,
        Mezistátní = 8,

    }
}

