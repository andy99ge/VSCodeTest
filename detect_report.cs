using myapp.model.report;

namespace myapp
{
    public class detect_report
    {
        public int id;

        //步速(m/s)
        public float stepSpeed = 0;

        //步幅(mm)	
        public int stride;

        //每步平均时间	
        public int usedTime;

        //左右每步时间差的平均值
        public int usedTime_rl;

        public int foot;

        public int ankle;

        public report_head head;

        public report_shoulder shoulder;

        public report_elbow elbow;

        public report_wrist wrist;

        public report_bigLeg bigLeg;

        public report_smallLeg smallLeg;

        public report_knee knee;

        public report_toe toe;

        public report_stepHead stepHead;

        public report_hip hip;

        public report_chest chest;

        public report_waist waist;

    }
}