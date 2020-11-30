<template>
  <div>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">     
        <b-form-group id="input-group-2" label="Enter ID:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="form.eId"
          required
        >this.eId</b-form-input>        
      </b-form-group>
      <b-button type="submit" variant="primary">Delete</b-button>
      <b-button type="reset" variant="danger">Reset</b-button>
    </b-form>
    </div>
</template>

<script>
import axios from 'axios';
  export default {
    data() {
      return {
        form: {
          eId: '',
          eName:'',
          eNumber:''
        },
        
        show: true
      }
    },
    created() {
            this.form.eId = this.$route.params.eID;
        },
    methods: {
      onSubmit(evt) {
        evt.preventDefault()
        alert("Data Successfully Deleted!");
                axios.post('http://localhost:50069/api/AddressBook/Delete', 
                    this.form
                )
                .then((response) => {})
                .catch((evt) => {
                console.error(evt)
  })
      },
      onReset(evt) {
        evt.preventDefault()
        // Reset our form values
        this.form.eId = ''
        // Trick to reset/clear native browser form validation state
        this.show = false
        this.$nextTick(() => {
          this.show = true
        })
      }
    }
  }
</script>