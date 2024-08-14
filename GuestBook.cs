using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæstebog
{
    
    internal class GuestBook
    {
        List<User> m_users;
        List<Comment> m_comments;

        enum State
        {
            START,
            SELECTING,
            READING_COMMENTS_5,

        }
        State m_state;
        public GuestBook() { }

        void drawChoices()
        {
            Console.WriteLine("1: Læs kommentarer");
            Console.WriteLine("2: Login");
            Console.WriteLine("3: Lav Konto");
        }

        void selectOption(string option)
        {
            option = option.ToLower();
            switch (option)
            {
                case "1":
                    m_state = State.READING_COMMENTS_5;
                    break;



            }
        }

        void draw()
        {
           
            switch(m_state)
            {
                case State.START:
                    drawChoices();
                    break;
                case State.SELECTING:
                    break;
                case State.READING_COMMENTS_5:
                    break;
            }
        }

        void loop()
        {
            while(true) 
            {
                switch(m_state)
                {
                    case State.START:
                    draw();
                    m_state = State.SELECTING;
                        break;
                    case State.SELECTING:
                        selectOption(Console.ReadLine());
                        
                        break;

                }
                
            }
        }

        void init() 
        {

        }

        public void run()
        {
            init();
            loop();
        }

        

    }
}
