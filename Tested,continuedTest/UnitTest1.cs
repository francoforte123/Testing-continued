using Testing__continued;

namespace Tested_continuedTest
{
    public class UnitTest1 : IDisposable
    {
        var myQueueInteger = new MyQueue<int>();
        var myQueueString = new MyQueue<string>();

        public UnitTest1()
        {
            this.myQueueInteger= new MyQueue<int>();
            this.myQueueString = new MyQueue<string>();
        }

        MyQueue<int> myQueueInteger = new MyQueue<int>();
        MyQueue<string> myQueueString = new MyQueue<string>();

        [Fact]
        public void TestTheTailEmptyInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            myQueueInteger.Queue(3);
            Assert.Empty(this.myQueueInteger.array);
        }

        [Fact]
        public void QueueTestInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            Assert.Equal(2, this.myQueueInteger.firstElement);
        }

        [Fact]
        public void DequeueTestInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            myQueueInteger.Dequeue();
            Assert.True(this.myQueueInteger.firstElement.Equals(1));
        }

        [Fact]
        public void PeekTestInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            var getValue = this.myQueueInteger.Peek();
            Assert.Equivalent(1, getValue);
        }




        [Fact]
        public void TestTheTailEmptyString()
        {
            myQueueString.Queue("Leonardo");
            myQueueString.Queue("Luigi");
            myQueueString.Queue("Mario");
            Assert.Empty(this.myQueueString.array);
        }

        [Fact]
        public void QueueTestString()
        {
            myQueueString.Queue("Marco");
            myQueueString.Queue("Luca");
            var result = this.myQueueString.firstElement;
            Assert.Equivalent(2, result);
        }

        [Fact]
        public void DequeueTestString()
        {
            myQueueString.Queue("Luca");
            myQueueString.Queue("Emanuele");
            myQueueString.Dequeue();
            Assert.Equivalent(1, this.myQueueString.firstElement);
        }

        [Fact]
        public void PeekTestString()
        {
            myQueueString.Queue("Franco");
            myQueueString.Queue("Anna");
            string getPeekElement = this.myQueueString.Peek();
            Assert.Equivalent("Franco", getPeekElement);
        }
    }
}