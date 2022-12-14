struct Solution{

}

impl Solution {
    pub fn search_insert(nums: Vec<i32>, target: i32) -> i32 {
        let mut i: i32 = 0;

        for num in nums.iter() {
            if *num >= target {
                return i;
            }
            i += 1;
        }

        return i;
    }
}

// ----- MAIN -----
fn main(){
    println!("{}", Solution::search_insert([1,3,5,6].to_vec(), 2));
}
