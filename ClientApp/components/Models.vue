<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>v-model: To do a two way binding</h3>
        <span>Bind to a data property</span>
        <input type="text" v-model="txtValue" /><br/>
        Value: {{txtValue}}
        <br/> <button @click="Update()">Update text</button>
        <br />
        <h3>bind other type of attributes</h3>
        <input type="checkbox" name="val1" v-model="chkValue" /> <br/>
        Checkbox is: {{chkValue}}
        <br />
        <h3>Bind to an array</h3>
        <input type="checkbox" name="val1" value="Green" v-model="arr" /><br />
        <input type="checkbox" name="val2" value="Red"  v-model="arr"/><br />
        color(s): {{arr}}
        <br />
        <h3>bind radio buttons</h3>
        <input type="radio" value="Tall" v-model="rad" />
        <input type="radio" value="Short" v-model="rad" />
        <br/>
        You are: {{rad}}
        <br />
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Models',
                txtValue: '',
                chkValue: '',
                arr: [],
                rad:''
            }
        },
        methods: {
            Update: function () {
                this.txtValue = "New value from script";
            }
        }
    }
</script>

<style>
    .redCss {
        color: red;
    }

    .blueCss {
        color: blue;
    }
</style>
