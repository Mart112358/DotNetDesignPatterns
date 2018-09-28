namespace DotNetDesignPatterns.Facade
{
    /* Facade */
    internal class Computer
    {
        private const long BootAddress = 150;
        private const long BootSector = 10;
        private const int SectorSize = 75;
        private readonly CPU _cpu;
        private readonly HardDrive _hardDrive;
        private readonly Memory _memory;

        public Computer()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _hardDrive = new HardDrive();
        }

        public static void Start()
        {
            CPU.Freeze();
            Memory.Load(BootAddress, HardDrive.Read(BootSector, SectorSize));
            CPU.Jump(BootAddress);
            CPU.Execute();
        }
    }
}