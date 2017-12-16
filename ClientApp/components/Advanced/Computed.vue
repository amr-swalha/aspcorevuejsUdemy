<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>Computed Propertise are a great way to cache data</h3>
        <span>The value is: {{val}}</span>
        <br />
        <button @click="CallComputed()">Get value</button>
        <br />
        <h3>Computed Propertise with get/set</h3>
        <span>{{active}}</span>
        <br />
        <button @click="updateComputed()">Update Value</button>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Computed Propertise',
                val: '',
                temp:''
            }
        },
        methods: {
            CallComputed: function () {
                
                this.val = this.computedData;
            },
            valueReturn: function () {
                console.log("computed!");
                return "amr";
            },
            updateComputed: function () {
                this.active = "aaaaa";
            }
        },
        computed: {
            computedData: function () {
                return this.valueReturn();
            },
            active: {
                get:function() {
                    return this.temp;
                },
                set: function(value) {
                    this.temp = value;
                }
            }
        }
    }
</script>

<style>

</style>
