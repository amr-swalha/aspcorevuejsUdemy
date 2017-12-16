<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>v-if: Conditional showing</h3>
        <span v-if="3 < 5">hide me!</span>
        <br />
        <h3>v-html: bind html to element</h3>
        <span v-html="newSpan"></span>
        <br />
        <h3>v-once: Only show changes once on the element</h3>
        <span>{{msg}}</span><br />
        <button @click="Update()">change title</button>
        <br />
        <h3>v-bind: bind data to the element</h3>
        <span :class="{'redCss':3<5}">v-bind:class span</span>
        <br />
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Directives',
                newSpan:`<span style='color:red;'>new Span</span>`
            }
        },
        methods: {
            Update: function () {
                this.msg = "test";
            }
        }
    }
</script>

<style>
    .redCss{
        color:red;
    }
</style>
