class MinStack {
    private int[] arr;
    private int[] minArr;
    private int top;
    public MinStack() {
        arr = new int[30000];
        minArr = new int[30000];
        top = -1;
    }
    
    public void push(int val) {
        top++;
        arr[top] = val;
        if(top > 0){
            minArr[top] = Math.min(minArr[top-1], val);
        }
        else {
            minArr[top] = val;
        }
    }
    
    public void pop() {
        top--;
    }
    
    public int top() {
        return arr[top];
    }
    
    public int getMin() {
        return minArr[top];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.push(val);
 * obj.pop();
 * int param_3 = obj.top();
 * int param_4 = obj.getMin();
 */