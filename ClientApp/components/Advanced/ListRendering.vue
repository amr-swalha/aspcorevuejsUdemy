<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>Rendering a simple list</h3>
        <span v-for="item in Items">
            Id:{{item.Id}}, Name:{{item.Name}}, Status:{{item.Status}}<br/>
        </span>
        <br />
        <h3>Index of the element</h3>
        <span v-for="(item,index) in Items">
            Index:{{index}} - Id:{{item.Id}}, Name:{{item.Name}}, Status:{{item.Status}}<br />
        </span>
        <br />
        <h3>iterate through an object</h3>
        <span v-for="(sing,key) in single">
        {{key}}:{{sing}}<br/>
            </span><br />
        <h3>Iterate with a range</h3>
        <ul>
            <li v-for="n in 5">{{n}}</li>
        </ul>
        <br />
        <h3>Iterate with a condition</h3>
        <ul>
            <li v-for="n in 10" v-if="n % 2 == 0">{{n}}</li>
        </ul>
        <br />
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'List Rendering',
                Items: [
                    { Id: 1, Name: 'First Item', Status: 'Available' },
                    { Id: 2, Name: 'Second Item', Status: 'Out of Stock' },
                    { Id: 3, Name: 'Third Item', Status: 'Available' },
                    { Id: 4, Name: 'Fourth Item', Status: 'Out of Stock' }
                ],
                single: {
                    Name: 'Ray',
                    Age:25
                }
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
    .redCss {
        color: red;
    }
</style>
