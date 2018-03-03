using Apache.NMS;
using Apache.NMS.ActiveMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility
{
    public class ActivemqHelper
    {
        private static IConnectionFactory factory;

        private static void Init()
        {
            try
            {
                factory = new ConnectionFactory("tcp://localhost:61616");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Send()
        {
            Init();
            try
            {
                //通过工厂建立连接
                using (IConnection connection = factory.CreateConnection())
                {
                    //通过连接创建Session会话
                    using (ISession session = connection.CreateSession())
                    {
                        //通过会话创建生产者，方法里面new出来的是MQ中的Queue
                        IMessageProducer producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue("myQueue"));
                        //创建一个发送的消息对象
                        ITextMessage message = producer.CreateTextMessage();
                        //给这个对象赋实际的消息
                        message.Text = "消息内容";
                        //设置消息对象的属性，这个很重要哦，是Queue的过滤条件，也是P2P消息的唯一指定属性
                        message.Properties.SetString("filter", "demo");
                        //生产者把消息发送出去，几个枚举参数MsgDeliveryMode是否长链，MsgPriority消息优先级别，发送最小单位，当然还有其他重载
                        producer.Send(message, MsgDeliveryMode.NonPersistent, MsgPriority.Normal, TimeSpan.MinValue);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Consume()
        {
            //创建连接工厂
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            //通过工厂构建连接
            IConnection connection = factory.CreateConnection();
            //这个是连接的客户端名称标识
            connection.ClientId = "firstQueueListener";
            //启动连接，监听的话要主动启动连接
            connection.Start();
            //通过连接创建一个会话
            ISession session = connection.CreateSession();
            //通过会话创建一个消费者，这里就是Queue这种会话类型的监听参数设置
            IMessageConsumer consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue("firstQueue"), "filter='demo'");
            //注册监听事件
            consumer.Listener += new MessageListener(consumer_Listener);
            //connection.Stop();
            //connection.Close();  
        }

        static void consumer_Listener(IMessage message)
        {
            ITextMessage msg = (ITextMessage)message;
            //异步调用下，否则无法回归主线程
            //tbReceiveMessage.Invoke(new DelegateRevMessage(RevMessage), msg);

        }

        public delegate void DelegateRevMessage(ITextMessage message);

        public void RevMessage(ITextMessage message)
        {
            //tbReceiveMessage.Text += string.Format(@"接收到:{0}{1}", message.Text, Environment.NewLine);
        }
    }
}
