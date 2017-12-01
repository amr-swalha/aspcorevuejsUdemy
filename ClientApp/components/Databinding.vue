<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>v-bind: To bind values to html attributes</h3>
        <span v-bind:class="'redCss'">Make me red!</span>
        <br />
        <h3>bind other attributes</h3>
        <span v-bind:title="'hello I\'m a tooltip'">add me a title</span>
        <br />
        <h3>updated bind</h3>
        <span v-bind:class="cssClass">See my color updated</span><br />
        <button @click="Update()">change title</button>
        <br />
        <h3>short hand version</h3>
        <span :class="'blueCss'">v-bind shot verison</span>
        <br />
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Databinding',
                cssClass: 'redCss'
            }
        },
        methods: {
            Update: function () {
                this.cssClass = "blueCss";
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
