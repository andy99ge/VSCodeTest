using myapp.model;

namespace myapp
{
    public class frame_result
    {
        //骨架ID
        public int id;

        //时间戳linux格式
        public double time;

        //人脸图像(100x100)
        public string imageBase64;

        //胳膊
        public person_elbow elbow;

        //头部
        public person_head head;

        //腿部
        public person_leg leg;

        //肩膀
        public person_shoulder shoulder;

        //腰部
        public person_hip hip;

        //躯干
        public person_chest chest;

        //手腕
        public person_wrist wrist;

        //骨架
        public Bone bone;

    }
}